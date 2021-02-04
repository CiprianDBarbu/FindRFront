import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public housings: Housing[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Housing[]>(baseUrl + 'housing').subscribe(result => {
      this.housings = result;
    }, error => console.error(error));
  }
}

interface Housing {
  link: string;
  price: number;
  noOfRooms: number;
  location: string;
}
