import ToDo, { IToDo } from './ToDo'

export default function ToDoList({ todos, toggleToDo }: { todos: IToDo[], toggleToDo: (id: string) => void }) {
  return (
      todos.map(todo => {
        return <ToDo key={todo.id} todo={todo} toggleTodo={toggleToDo}/>
      })
  )
}
