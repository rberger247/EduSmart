import { Component } from '@angular/core';
import { AuthService } from '../../Services/auth.service';

@Component({
    selector: 'nav-menu',
    templateUrl: './navmenu.component.html',
    styleUrls: ['./navmenu.component.css'],
    providers: [AuthService]

})
export class NavMenuComponent {
    constructor(private auth: AuthService) { }
}
