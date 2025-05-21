import { Component, EventEmitter, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  @Output() closeModal = new EventEmitter<void>();
  @Output() registerSubmit = new EventEmitter<any>();

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
      this.registerSubmit.emit(this.Register.value);
      this.onClose();
    } else {
      this.Register.markAllAsTouched();
    }
  }

  onClose() {
    this.closeModal.emit();
  }
}
