import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { AlertifyService } from './../../../../_service/alertify.service';
import { Login } from './../../../../Models/Login.model';
import { AuthService } from './../../../../_service/auth.service';

@Component({
  selector: 'app-basic-login',
  templateUrl: './basic-login.component.html',
  styleUrls: ['./basic-login.component.scss']
})
export class BasicLoginComponent implements OnInit {
  loginForm: FormGroup;
  constructor(private Model: Login, private authService: AuthService, private router: Router,
    private alertify: AlertifyService) { }

  ngOnInit() {
    this.loginForm = new FormGroup({
      Email: new FormControl(this.Model.Email),
      Password: new FormControl(this.Model.Password)
    })
    document.querySelector('body').setAttribute('themebg-pattern', 'theme1');
  }
  login() {
    let valuse = this.loginForm.value;
    if (valuse.Email == "admin@khanorganicfoods.pk" && valuse.Password == "KofAdmin@12") {
      localStorage.setItem('user', valuse.Email);
      this.router.navigate(['/dashboard']);
    }
    else {
      this.alertify.error("Wrong Email and password")
    }
    // tslint:disable-next-line: no-debugger

    //  this.authService.login(this.loginForm.value).subscribe(next => {
    //    this.alertify.success('logged in successfully');
    //    this.router.navigate(['/dashboard']);
    //  }, error => {
    //    this.alertify.error('Login Failed');
    //  });
  }
  loggedIn() {
    const token = localStorage.getItem('token');
    return !!token;
  }
}
