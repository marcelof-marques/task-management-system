import { Project } from './project';
import { Role } from './role';

/** Utilizador */
export class User {
    /** Identificador do Utilizador */
    id: number;
    name: string;
    email: string;
    roles: Role[];
    projects: Project[];
}
