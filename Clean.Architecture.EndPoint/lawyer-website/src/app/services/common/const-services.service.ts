import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { HeaderItem } from '../../interface/header-item';
import { environment } from '../../../environment/environment'




@Injectable({
  providedIn: 'root'
})
export class ConstService {

  private baseUrl = environment.apiBaseUrl;

  constructor(private http: HttpClient) {}

  getHeader(key: string): Observable<HeaderItem[]> {
    const url = `${this.baseUrl}/api/Const/getallconst?key=${encodeURIComponent(key)}`;
    return this.http.get<HeaderItem[]>(url);
  }
}
