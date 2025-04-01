import { Component, inject, OnInit } from '@angular/core';
import { ProdutosApiService } from '../../services/produtos-api.service';
import { CurrencyPipe } from '@angular/common';

@Component({
  selector: 'app-list-products',
  imports: [CurrencyPipe],
  templateUrl: './list-products.component.html',
  styleUrl: './list-products.component.scss'
})
export class ListProductsComponent implements OnInit {
  #productService = inject(ProdutosApiService);
  
  public getProductList = this.#productService.getProductList;
  
  ngOnInit(): void {
    this.#productService.httpProductList$().subscribe();
  }
}
