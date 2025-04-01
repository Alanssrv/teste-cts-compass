import { Component } from '@angular/core';
import { HeaderComponent } from "../../components/header/header.component";
import { ListProductsComponent } from "../../components/list-products/list-products.component";
import { FooterComponent } from "../../components/footer/footer.component";

@Component({
  selector: 'app-home',
  imports: [HeaderComponent, ListProductsComponent, FooterComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {

}
