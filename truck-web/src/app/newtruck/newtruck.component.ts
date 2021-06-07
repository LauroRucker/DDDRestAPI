import { Component, OnInit } from '@angular/core';
import { Truck } from '../models/Trucks';
import { TruckService } from '../services/truck.service'

@Component({
  selector: 'app-newtruck',
  templateUrl: './newtruck.component.html',
  styleUrls: ['./newtruck.component.scss']
})
export class NewtruckComponent implements OnInit {

  TModel!: string;
  YM!: number;
  YF!: number;

  constructor(private truckservice: TruckService) { }

  ngOnInit(): void {
  }

  insertTruck(){
    
      let truck_params = {
      "TModel": this.TModel,
      "YearModel": this.YM,
      "YearFab": this.YF
    }

    this.truckservice.addTruck(JSON.stringify(truck_params))
  }

}
