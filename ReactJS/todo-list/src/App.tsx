import { useState, useRef, useEffect } from "react"
import ToDoList from "./ToDoList"
import { v4 as uuidv4 } from "uuid";
import { IToDo } from "./ToDo";

const LOCAL_STORAGE_KEY = 'todoApp.todos'

function App() {
  const [todos, setTodos] = useState<IToDo[]>([])
  const todoNameRef = useRef<HTMLInputElement>(null)

  useEffect(() => {
    const a = JSON.parse(localStorage.getItem(LOCAL_STORAGE_KEY) || '[]');
    if (a.length > 0) {
      setTodos(a)
    }
  }, [])

  useEffect(() => {
    localStorage.setItem(LOCAL_STORAGE_KEY, JSON.stringify(todos))
  }, [todos])

  
  function toggleTodo(id: string) {
    const newTodos = [...todos]
    const todo = newTodos.find(todo => todo.id === id)
    if (todo) {
      todo.complete = !todo.complete
      setTodos(newTodos)
    }
  }

  function handleClearTodos() {
    const newTodos = todos.filter(todo => !todo.complete)
    setTodos(newTodos)
  }

  function handleAddTodo(e: React.MouseEvent<HTMLButtonElement, MouseEvent>) {
    const name = todoNameRef.current?.value
    if (name === '') return
    //todoNameRef.current.value = null;
    
    setTodos(prevTodos => {
      const newID = uuidv4()
      return [...prevTodos, { id: newID, name: name ?? '', complete: false }]
    })
  }

  return (
    <>
      <ToDoList todos={todos} toggleToDo={toggleTodo} />
      <input ref={todoNameRef} type="text" />
      <button onClick={handleAddTodo}>Add ToDo</button>
      <button onClick={handleClearTodos}>Clear Complete</button>
      <div>{todos.filter(todo => !todo.complete).length} left to do</div>
    </>
  )
}

export default App
