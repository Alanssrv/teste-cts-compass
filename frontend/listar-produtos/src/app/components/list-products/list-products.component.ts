import { Component, inject, OnInit } from '@angular/core';
import { ProdutosApiService } from '../../services/produtos-api.service';
import { CurrencyPipe } from '@angular/common';

// Componente de listagem de produtos da aplicação
@Component({
  selector: 'app-list-products',
  imports: [CurrencyPipe],
  templateUrl: './list-products.component.html',
  styleUrl: './list-products.component.scss'
})
export class ListProductsComponent implements OnInit {
  
  // Injeção de dependência com a classe de integração com o serviço de produtos
  #productService = inject(ProdutosApiService);
  
  // Resgatando a lista de produtos mapeada na classe de integração
  public getProductList = this.#productService.getProductList;
  
  ngOnInit(): void {
    // Inicialização do componente chamando o método de resgate de todos os produtos
    this.#productService.httpProductList$().subscribe();
  }
}
