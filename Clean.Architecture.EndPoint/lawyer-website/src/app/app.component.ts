import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';

// import های لازم برای مودال
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { RegisterComponent } from './pages/register/register.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterModule,
    MatDialogModule
  ],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
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
    const dialogRef = this.dialog.open(RegisterComponent, {
      width: '400px'
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        console.log('اطلاعات ثبت‌نام:', result);
        // اینجا می‌تونی ارسال به سرور انجام بدی یا هر کاری
      }
    });
  }
 
}
