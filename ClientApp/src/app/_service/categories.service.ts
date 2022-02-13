import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../src/environments/environment.prod';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {
  baseUrl = environment.apiurl + 'ProductApi/';
constructor(private http: HttpClient) { }

}
