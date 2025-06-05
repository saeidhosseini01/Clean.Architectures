import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { environment } from '../../../environment/environment';
import { TValue } from '../../interface/TValue';







@Injectable({
  providedIn: 'root'
})
export class ConstService {

  private baseUrl = environment.apiBaseUrl;

  constructor(private http: HttpClient) {}

 public getConstByKey(key: string): Observable<TValue<string>[]> {
    const url = `${this.baseUrl}/Const/GetConstByKey?key=${encodeURIComponent(key)}`;
    return this.http.get<TValue<string>[]>(url);
  }
  
}
