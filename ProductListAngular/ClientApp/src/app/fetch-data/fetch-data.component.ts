import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public products: Product[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    //http.get<WeatherForecast[]>(baseUrl + 'api/SampleData/WeatherForecasts').subscribe(result => {
    http.get<Product[]>(baseUrl + 'api/Product/GetProducts').subscribe(result => {
      this.products = result;
    }, error => console.error(error));
  }
}

//interface WeatherForecast {
//  dateFormatted: string;
//  temperatureC: number;
//  temperatureF: number;
//  summary: string;
//}

interface Product {
  productId: number;
  name: string;
  price: number;
  stock: number;
  image: string;
}
