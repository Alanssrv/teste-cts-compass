import { Component, inject, OnInit } from '@angular/core';
import { ProdutosApiService } from '../../services/produtos-api.service';
import { JsonPipe } from '@angular/common';

@Component({
  selector: 'app-list-products',
  imports: [JsonPipe],
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
