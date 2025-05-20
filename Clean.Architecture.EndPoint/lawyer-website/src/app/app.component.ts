import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  onLearnMore() {
    alert('بیشتر به زودی اضافه می‌شود!');
  }
  contact() {
  throw new Error('خطا: تماس فعلاً غیر فعال است!');
}
}
