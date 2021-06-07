import { Component, OnInit } from '@angular/core';
import { Truck } from '../models/Trucks';
import { TruckService } from '../services/truck.service'

@Component({
  selector: 'app-gettrucks',
  templateUrl: './gettrucks.component.html',
  styleUrls: ['./gettrucks.component.scss']
})
export class GettrucksComponent implements OnInit {

  constructor(private truckservice: TruckService) { }

  id! : number
  TModel!: string;
  YM!: number;
  YF!: number;

  ngOnInit(): void {
  }

  getTrucks(){
    
    let truck_params = {
    "TModel": this.TModel,
    "YearModel": this.YM,
    "YearFab": this.YF
  }

  this.truckservice.getTrucks().subscribe(res => res)
}

getTruck(){
    
  let truck_params = {
  "TModel": this.TModel,
  "YearModel": this.YM,
  "YearFab": this.YF
}

this.truckservice.getTruck(this.id).subscribe(res => res)
}

}
