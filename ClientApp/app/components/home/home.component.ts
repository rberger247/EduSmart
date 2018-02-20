import { Component } from '@angular/core';
import { AuthService } from '../../Services/auth.service';

@Component({
    selector: 'home',
    templateUrl: './home.component.html',
    providers: [AuthService]
})
export class HomeComponent {
    constructor(private auth: AuthService) { }
}
