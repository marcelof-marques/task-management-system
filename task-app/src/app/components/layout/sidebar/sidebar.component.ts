import { Component } from '@angular/core';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent {

  toggleSideBar() {
    let sidebar = document.querySelector(".sidebar");
    let closeBtn = document.querySelector("#btn");

    sidebar.classList.toggle("open");

    if (sidebar.classList.contains("open")) {
      closeBtn.classList.replace("bx-menu", "bx-menu-alt-right");//replacing the icons class
    } else {
      closeBtn.classList.replace("bx-menu-alt-right", "bx-menu");//replacing the icos class
    }
  }
}
