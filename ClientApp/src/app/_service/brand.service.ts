import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../src/environments/environment.prod';

@Injectable({
  providedIn: 'root'
})
export class BrandService {
  baseUrl = environment.apiurl + 'ProductApi/';
constructor(private http: HttpClient) { }
GetBrands(){
  return this.http.get<any>(this.baseUrl+'GetAllBrands')
};
AddBrand(form: any){
  return this.http.post<any>(this.baseUrl+'AddBrand', form)
};
}
