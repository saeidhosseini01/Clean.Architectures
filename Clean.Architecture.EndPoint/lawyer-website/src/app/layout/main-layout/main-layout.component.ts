import { Component } from '@angular/core';
import { RouterModule, RouterOutlet } from '@angular/router';

import { MatDialog, MatDialogModule } from '@angular/material/dialog';







import { RegisterComponent } from '../../pages/register/register.component';
import { FormsModule } from '@angular/forms';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from '../../core/header/header.component';
import { SidebarComponent } from '../../core/sidebar/sidebar.component';

import { FooterComponent } from '../../core/footer/footer.component';






@Component({
  selector: 'main-layout-root',
  standalone: true,
  imports: [
    RouterModule,
    MatDialogModule,FormsModule, MatInputModule, MatButtonModule, FormsModule,
     CommonModule, RouterOutlet,HeaderComponent,FooterComponent,SidebarComponent
  ],
  templateUrl: './main-layout.component.html',
  styleUrls: ['./main-layout.component.css']
})
export class MainLayoutComponent {
  constructor(private dialog: MatDialog) {}

  onLearnMore() {
    alert('بیشتر به زودی اضافه می‌شود!');
  }

  contact() {
    throw new Error('خطا: تماس فعلاً غیر فعال است!');
  }

  scrollToContact() {
    document.querySelector('#contact')?.scrollIntoView({ behavior: 'smooth' });
  }
  openRegisterDialog() {
      this.openPupUp();
    }
openPupUp() {
    this.dialog.open(RegisterComponent, {
      width: '50%',
      enterAnimationDuration: '1000ms',
      exitAnimationDuration: '1000ms'
    });}
 
  
 
}
