/*
Write a functional component called Counter that renders a counter with increment and 
decrement buttons. It should maintain its own internal state for the count value and 
update it accordingly when the buttons are clicked.
*/

import { useState } from "react";

export default function Counter() {
    const [count, setCount] = useState(0);

    return <div>
        <div>Count: {count}</div>
        <button onClick={() => setCount(count - 1)}>Decrement</button>
        <button onClick={() => setCount(count + 1)}>Increment</button>
    </div>
}