import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NgFor } from '@angular/common';
import { json, text } from 'stream/consumers';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,NgFor],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent  implements OnInit {
  users: any[] = [];
  constructor (private http:HttpClient){};
  ngOnInit(): void {
    
    this.http.get<any[]>('https://localhost:7139/api/user/getAllUsers').subscribe({
      
      next:data=> this.users=data,
      error :err => console.error('api error')
    })
  }


  title = 'ClientApp';
}
