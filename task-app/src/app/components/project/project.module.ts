import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProjectRoutingModule } from './project-routing.module';
import { ProjectsComponent } from './projects/projects.component';
import { ProjectContainerComponent } from './project-container/project-container.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
    declarations: [ProjectsComponent, ProjectContainerComponent],
    imports: [CommonModule, ProjectRoutingModule, NgbModule],
})
export class ProjectModule {}
