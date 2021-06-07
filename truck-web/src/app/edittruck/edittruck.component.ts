import { Component, OnInit } from '@angular/core';
import { Truck } from '../models/Trucks';
import { TruckService } from '../services/truck.service'

@Component({
  selector: 'app-edittruck',
  templateUrl: './edittruck.component.html',
  styleUrls: ['./edittruck.component.scss']
})
export class EdittruckComponent implements OnInit {

  TModel!: string;
  YM!: number;
  YF!: number;


  constructor(private truckservice: TruckService) { }

  ngOnInit(): void {
  }

  updateTruck(){
    let truck_params = {
      "TModel": this.TModel,
      "YearModel": this.YM,
      "YearFab": this.YF
    }
    this.truckservice.updateTruck(JSON.stringify(truck_params))
    alert("Truck Edited")
  }

}
