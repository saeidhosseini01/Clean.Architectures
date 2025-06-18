import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { UserDto } from "../../interface/UserDto";
import { environment } from '../../../environment/environment';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})






export class UserService {

    private baseUrl = environment.apiBaseUrl;

  constructor(private http: HttpClient) {}

public addUser(entity: UserDto): Observable<boolean> {
    const url = `${this.baseUrl}/User/AddUser?key=${entity}`;
    return this.http.get<boolean>(url);
  }


}
