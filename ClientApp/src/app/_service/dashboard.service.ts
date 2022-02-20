import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../src/environments/environment.prod';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {
  baseUrl = environment.apiurl + 'Dashboard/';
constructor(private http: HttpClient) { }
GetDashboardData(){
  return this.http.get<any>(this.baseUrl+'DashboardData')
};
Todaysale(){
  return this.http.get<any>(this.baseUrl+'Todaysale')
};
Datefilter(form: any){
  return this.http.post<any>(this.baseUrl+'MonthlySale', form)
};
}
