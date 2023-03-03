import { Component } from '@angular/core';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent {

  toggleSideBar() {
    // vai buscar a o div da side bar e do botao
    const sidebar = document.querySelector(".sidebar");
    const closeBtn = document.querySelector("#btn");

    // abre ou fecha a side bar
    sidebar.classList.toggle("open");

    // se estiver aberta coloca uns icons se nao coloca outros
    if (sidebar.classList.contains("open")) {
      closeBtn.classList.replace("bx-menu", "bx-menu-alt-right");
    } else {
      closeBtn.classList.replace("bx-menu-alt-right", "bx-menu");
    }
  }
}
