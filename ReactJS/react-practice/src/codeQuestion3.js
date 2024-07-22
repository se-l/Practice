/*
Write a component called Accordion that renders an accordion-style UI. It should receive an array 
of items as a prop, and each item should have a title and content. 
Only one item should be expanded at a time.
*/

import { useState } from "react";

export default function AccordionUI({items})
{
    const [expIndex, setExpIndex] = useState(null);

    return (
        <>
        {items.map((item, index) => (
            <div key={index}>
                <h2 onClick={() => setExpIndex(item.index)}>{item.title}</h2>
                {expIndex == item.index && <div>{item.content}</div>}
            </div>
        ))}
        </>
    )
}