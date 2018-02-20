import { Component } from '@angular/core';
import { AuthService } from '../../Services/auth.service';

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css'],
    providers: [AuthService]
})
export class AppComponent {
    constructor(public auth: AuthService) {
        auth.handleAuthentication();
    }
}
