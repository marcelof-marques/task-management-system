import { Component, OnDestroy } from '@angular/core';
import { Observable, Subject, takeUntil } from 'rxjs';
import { ProjectService } from '../../../services/project-service.service';
import { Project } from '../../../../models/project';

@Component({
    selector: 'div[app-projects]',
    templateUrl: './projects.component.html',
    styleUrls: ['./projects.component.css'],
})
export class ProjectsComponent implements OnDestroy {
    private destroy$ = new Subject();

    projects$: Observable<Project[]>;
    _projects: Project[];

    constructor(private projectService: ProjectService) {
        this.projects$ = this.projectService.getProjects();
        console.log(this.projects$);
    }

    /** retorna os projetos e valida se os projetos ja estao guardados numa variavel se nao vai a stream buscar os dados */
    get projects(): Project[] {
        if (this._projects) {
            return this._projects;
        } else {
            this.projects$
                .pipe(takeUntil(this.destroy$))
                .subscribe((projects: Project[]) => {
                    this._projects = projects;
                });
            return this._projects;
        }
    }

    ngOnDestroy(): void {
        this.destroy$.next(true);
        this.destroy$.complete();
    }
}
