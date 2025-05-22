import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule, RouterOutlet } from '@angular/router';







@Component({
   selector: 'app-root',
  standalone: true,
  imports: [
    RouterModule,
    FormsModule, FormsModule,
     CommonModule, RouterOutlet
  ],
  template: `<router-outlet></router-outlet>`, // ✅ فقط روتینگ
})
export class AppComponent {}
