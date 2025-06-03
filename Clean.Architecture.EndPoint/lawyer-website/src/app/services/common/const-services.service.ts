import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { HeaderItem } from '../../interface/header-item';

@Injectable({
  providedIn: 'root'
})
export class ConstService {
private apiUrl = 'https://localhost:5001/api/header';

  constructor(private http: HttpClient) { }
   getHeader():Observable<HeaderItem[]>{

    return this.http.get<HeaderItem[]>(this.apiUrl)
  }
}
