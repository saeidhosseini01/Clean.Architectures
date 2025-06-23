import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { IUserDto } from "../../interface/UserDto";
import { environment } from '../../../environment/environment';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})






export class UserService {

    private baseUrl = environment.apiBaseUrl;

  constructor(private http: HttpClient) {}

public addUser(entity: IUserDto): Observable<boolean> {

    const url = `${this.baseUrl}/User/AddUser?userDto=${entity}`;
  
    return this.http.get<boolean>(url);
  }
  public updateUser(entity: IUserDto): Observable<boolean> {
  alert("update");
    //const url = `${this.baseUrl}/User/UpdateUser?userDto=${entity}`;
    const url = `${this.baseUrl}/User/UpdateUser`;
    return this.http.get<boolean>(url);
  }


}
