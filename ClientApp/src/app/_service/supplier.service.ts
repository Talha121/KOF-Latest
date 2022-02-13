import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../src/environments/environment.prod';
import { Supplier } from '../Models/Supplier.model';

@Injectable({
  providedIn: 'root'
})
export class SupplierService {
  baseUrl = environment.apiurl + 'SupplierApi/';
constructor(private http: HttpClient) { }
postsupplier(form: any){
  return this.http.post<any>(this.baseUrl+'AddSupplier', form)
};
Getsupplier(){
  return this.http.get<Supplier>(this.baseUrl+'AllSuppliers')
};

}

