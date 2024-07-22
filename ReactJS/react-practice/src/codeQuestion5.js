/*
Write a component called Tabs that renders a tab-based navigation. 
It should receive an array of tabs as a prop, and each tab should be
 displayed as a button. When a tab is clicked, it should be highlighted
  as active, and its corresponding content should be displayed.
*/

import { useState } from "react";

export default function Tabs({tabs}) {
    const [activeIndex, setActiveIndex] = useState(0);

    return (
        <div>
            {tabs.map((tab, index) => <button className={activeIndex == index ? 'active' : ''}  key={index} onClick={() => setActiveIndex(index)}>{tab.title}</button>)}
            <div>{tabs[activeIndex].content}</div>
        </div>
    )
}