import { TaskType } from './task-type';
import { TaskState } from './task-state';

/** Tarefa */
export class Task {
    /** Identificador da Tarefa */
    id: number;

    /** Nome da Tarefa */
    name: string;

    /** Descrição da Tarefa */
    description: string;

    /** Tipo de Tarefa */
    type: TaskType;

    /** Estado da Tarefa */
    state: TaskState;
}
