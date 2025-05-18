import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-show-users',
  imports: [RouterModule,CommonModule,HttpClientModule],
  templateUrl: './show-users.component.html',
  styleUrl: './show-users.component.css'
})
export class ShowUsersComponent {
 users: any[] = [];
  constructor (private http:HttpClient){};
  ngOnInit(): void {
    
    this.http.get<any[]>('https://localhost:7139/api/user/getAllUsers').subscribe({
      
      next:data=> this.users=data,
      error :err => console.error('api error')
    })
}
}