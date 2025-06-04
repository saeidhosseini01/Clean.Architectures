import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { ConstItem } from '../../interface/const-item';
import { environment } from '../../../environment/environment';







@Injectable({
  providedIn: 'root'
})
export class ConstService {

  private baseUrl = environment.apiBaseUrl;

  constructor(private http: HttpClient) {}

 public getConstByKey(key: string): Observable<ConstItem[]> {
    const url = `${this.baseUrl}/Const/GetConstByKey?key=${encodeURIComponent(key)}`;
    return this.http.get<ConstItem[]>(url);
  }
  
}
