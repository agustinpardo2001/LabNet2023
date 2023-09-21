import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import {MatSnackBar, MatSnackBarHorizontalPosition, MatSnackBarModule, MatSnackBarVerticalPosition} from '@angular/material/snack-bar';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
  export class LoginComponent {
   hide: boolean = true;
   formLogin:FormGroup;
   loading: boolean = false;
   horizontalPosition: MatSnackBarHorizontalPosition | undefined;
   verticalPosition: MatSnackBarVerticalPosition | undefined;
 

    constructor(private fb:FormBuilder, private _snackBar: MatSnackBar, private router: Router) {
    this.formLogin = this.fb.group({
    userName:['',Validators.required,],
    password:['',Validators.required],
    });
    }
    loginAccount() {
    console.log(this.formLogin);
  
    const userName = this.formLogin.value.userName;
    const password = this.formLogin.value.password;

    if (userName == "labnet" && password == "2023"){
      this.fakeRedirections();
    } else {
      this.errorMessage();
    }

  }
    fakeRedirections(){
      this.loading=true;
      setTimeout(() =>{
        this.router.navigate(['dashboard']);
        this.loading=false;
      },1500);
    }


    errorMessage() {
      this._snackBar.open('Usuario o Contraseña Incorrectos', 'Cerrar', {
        duration: 3000,
        horizontalPosition: "center",
        verticalPosition: "bottom",
      });
    } 
    
  }
  



