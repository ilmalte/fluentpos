import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Customer } from '../models/customer';

@Injectable()
export class CustomerApiService {

  baseUrl = environment.apiUrl + 'people/customers';

  constructor(private http: HttpClient) {
  }

  getAlls(params: HttpParams) {
    return this.http.get(this.baseUrl, {params: params});
  }

  getById(id: string) {
    return this.http.get<Customer>(this.baseUrl + `/${id}`);
  }

  create(customer: Customer) {
    return this.http.post(this.baseUrl, customer);
  }

  update(customer: Customer) {
    return this.http.put(this.baseUrl, customer);
  }

  delete(id: string) {
    return this.http.delete(this.baseUrl + `/${id}`);
  }
}
