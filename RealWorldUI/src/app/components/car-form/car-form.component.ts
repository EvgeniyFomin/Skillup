import { Component, OnInit } from '@angular/core';
import { CarService } from '../../services/car.service';

@Component({
  selector: 'app-car-form',
  templateUrl: './car-form.component.html',
  styleUrls: ['./car-form.component.css']
})

export class CarFormComponent implements OnInit {

  constructor(private carService: CarService) { }

  ngOnInit() {
    this.carService.getHuy().subscribe((data: any) => {
      debugger;

    }, err => {
      debugger;
    });

  }

}
