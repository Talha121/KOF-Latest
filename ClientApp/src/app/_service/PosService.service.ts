import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from './../../../src/environments/environment.prod';

@Injectable({
  providedIn: 'root'
})
export class PosServiceService {
  baseUrl = environment.apiurl + 'ProductApi/';
  baseUrl1 = environment.apiurl + 'PosOrder/';
constructor(private http: HttpClient) { }
value:string = "test";

GetSingleProducts(barcode:any){

  return this.http.post<any>(this.baseUrl+'BarcodeInfo',barcode)
};
PostPosOrder(data:any){

  return this.http.post<any>(this.baseUrl1+'saveposorder',data)
};
GetOrders(){
  return this.http.get<any>(this.baseUrl1+'GetAllOrders',httpOptions)
};
FindXtOrder(){
  return this.http.get<any>(this.baseUrl1+'NextOrder',httpOptions)
};
}
var headers_object = new HttpHeaders({
  'Content-Type': 'application/json',
   'Authorization': "Bearer "+localStorage.getItem('token')
});
const httpOptions = {
  headers: headers_object
};
