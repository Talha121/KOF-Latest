import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { environment } from '../../../src/environments/environment.prod';

@Injectable({
  providedIn: 'root'
})
export class VendorService {
  baseUrl = environment.apiurl + 'UsersApi/';
  baseUrl2 = environment.apiurl + 'LedgerAccount/';
constructor(private http: HttpClient) { }
Getvendors(){
  return this.http.get<any>(this.baseUrl+'AllVendors')
};
Updatestatus(Id:number):Observable<any>{

  return this.http.post<any>(this.baseUrl+'StatusChangeVendor', Id)}
  Vendordetail(Id:number):Observable<any>{

    return this.http.post<any>(this.baseUrl+'Vendorsprofile',Number(Id))}
    VendorOrders(Id:number):Observable<any>{

      return this.http.post<any>(this.baseUrl+'VendorOrders',Number(Id))}

      Vendorladger(Id:number):Observable<any>{

        return this.http.post<any>(this.baseUrl2+'GetVendorLedger',Number(Id))}
}

