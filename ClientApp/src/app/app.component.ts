

import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterModule],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'] // ✅ اصلاح‌شده
})
export class AppComponent {}
// export class AppComponent { 
//   //  this.http.get<any[]>('https://localhost:7139/api/user/getAllUsers').subscribe({
      
//   //     next:data=> this.users=data,
//   //     error :err => console.error('api error')
//   //   })
  
//  }  
