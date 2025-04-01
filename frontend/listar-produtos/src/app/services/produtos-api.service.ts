import { inject, Injectable, signal } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { IProduto } from '../models/product.interface';
import { Observable, tap, catchError, throwError } from 'rxjs';

// Componente de integração com serviço de Produtos
@Injectable({
  providedIn: 'root'
})
export class ProdutosApiService {
  
  #httpClient = inject(HttpClient);
  #url = signal(environment.produtoApiUrl);

  // Get e Set da lista de produtos
  #setProductList = signal<IProduto[] | null>(null);
  get getProductList() {
    return this.#setProductList.asReadonly();
  }

  // Integração, resgate e mapeamento da lista de produtos
  public httpProductList$() : Observable<IProduto[]> {
    this.#setProductList.set(null);
    
    return this.#httpClient.get<IProduto[]>(`${this.#url()}/produtos`).pipe(
      tap((res) => this.#setProductList.set(res)),
      catchError( (error: HttpErrorResponse) => {
        return throwError(() => error);
      })
    );
  }
}
