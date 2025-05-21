import { Component } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { NgIf } from '@angular/common';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatError } from '@angular/material/form-field';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [
    ReactiveFormsModule,
    NgIf,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatError
  ],
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  Register: FormGroup;

  constructor(
    private fb: FormBuilder,
    private dialogRef: MatDialogRef<RegisterComponent> // استفاده از MatDialogRef
  ) {
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
      this.dialogRef.close(this.Register.value); // بستن مودال و ارسال دیتا
    } else {
      this.Register.markAllAsTouched();
    }
  }

  onClose() {
    this.dialogRef.close(); // بستن مودال بدون دیتا
  }
}
