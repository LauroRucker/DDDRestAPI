import { Component, OnInit } from '@angular/core';
import { Truck } from '../models/Trucks';
import { TruckService } from '../services/truck.service'

@Component({
  selector: 'app-removetruck',
  templateUrl: './removetruck.component.html',
  styleUrls: ['./removetruck.component.scss']
})
export class RemovetruckComponent implements OnInit {

  TModel!: string;
  YM!: number;
  YF!: number;

  constructor(private truckservice: TruckService) { }

  ngOnInit(): void {
  }

  removeTruck(){
    this.truckservice.removeTruck(1)
  }
}
