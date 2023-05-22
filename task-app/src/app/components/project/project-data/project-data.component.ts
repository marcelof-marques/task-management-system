import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Project } from 'src/models/project';

@Component({
    selector: 'app-project-data',
    templateUrl: './project-data.component.html',
    styleUrls: ['./project-data.component.css'],
})
export class ProjectDataComponent {
    @Input() selectedProject: Project;
    @Output() selectedProjectChange = new EventEmitter<Project>();
}
