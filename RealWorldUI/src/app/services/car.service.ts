import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { environment } from '../../environments/environment';
import 'rxjs/add/operator/map';

@Injectable()
export class CarService {
  constructor(private http: Http) { }
  getAllCars() {

    let cars = this.http.get(environment.URI + '/api/Car').map(car => car.json());
    console.log(cars);
    return cars;
  }
  getHuy(){
    return this.http.get(environment.URI + '/api/huy');
  }

}
