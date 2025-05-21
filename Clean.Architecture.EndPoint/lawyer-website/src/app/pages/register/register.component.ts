
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
@Component({
  selector: 'app-register',
  standalone: true,
  imports: [
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule
  ],
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  Register: FormGroup;

  constructor(private fb: FormBuilder) {
    this.Register = this.fb.group({
      fname: ['', Validators.required],
      lname: ['', Validators.required],
      address: ['', Validators.required],
      phone: ['', [Validators.required, Validators.pattern(/^\d{10,15}$/)]],
      age: ['', [Validators.required, Validators.min(1), Validators.max(120)]],
    });
  }

  onSubmit() {
    if (this.Register.valid) {
      alert('عضو با موفقیت ثبت شد!\n' + JSON.stringify(this.Register.value, null, 2));
      this.Register.reset();
    } else {
      this.Register.markAllAsTouched();
    }
  }
}
