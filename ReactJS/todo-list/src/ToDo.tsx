export type IToDo = {
    id: string, 
    name: string,
    complete: boolean
}


export default function ToDo({todo, toggleTodo}: {todo: IToDo, toggleTodo: (id: string) => void}) {

function handleToClick() {
    toggleTodo(todo.id)
}

  return (
    <div>
        <label>
            <input type="checkbox" checked={todo.complete} onChange={handleToClick} />
            {todo.name}
        </label>
      {todo.name}
    </div>
  )
}
