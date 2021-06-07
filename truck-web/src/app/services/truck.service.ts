import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Truck } from '../models/Trucks';
import { environment } from '../../environments/environment';


@Injectable({
  providedIn: 'root'
})
export class TruckService {

  constructor(private http: HttpClient) { }

  getTrucks (): Observable<Truck[]> {
    return this.http.get<Truck[]>("https://localhost:44325/Trucks")
      .pipe(
        tap(_ => console.log('fetched truck')),
        catchError(this.handleError<Truck[]>('getTrucks', []))
      );
  }

  getTruck (id:number): Observable<Truck> {
    return this.http.get<Truck>("https://localhost:44325/Trucks" + id)
      .pipe(
        tap(_ => console.log('fetched truck')),
        catchError(this.handleError<Truck>('getTruck'))
      );
  }

  updateTruck (truck:string){
    this.http.put("https://localhost:44325/Trucks", JSON.stringify(truck)).subscribe((res)=>{
       console.log(res);
   });
  }

  addTruck (truck:string){
    this.http.post("https://localhost:44325/Trucks", JSON.stringify(truck)).subscribe((res)=>{
       console.log(res);
   });
  }

  removeTruck (id:number){
    this.http.delete("https://localhost:44325/Trucks"+id).subscribe((res)=>{
       console.log(res);
   });
  }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      //this.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }

}
