import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatTableModule } from '@angular/material/table';
import { MatSortModule } from '@angular/material/sort';
import { MatPaginatorModule } from '@angular/material/paginator';

import { ProjectRoutingModule } from './project-routing.module';
import { ProjectsComponent } from './projects/projects.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ProjectDataComponent } from './project-data/project-data.component';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
    declarations: [ProjectsComponent, ProjectDataComponent],
    imports: [
        CommonModule,
        ProjectRoutingModule,
        NgbModule,
        MatIconModule,
        MatButtonModule,
        MatTableModule,
        MatSortModule,
        MatPaginatorModule,
        ReactiveFormsModule,
    ],
})
export class ProjectModule {}
