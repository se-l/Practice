/*
Question: Write a functional component called Navbar that renders a navigation bar with links. 
It should receive an array of links as a prop, and each link should be displayed as an anchor tag within a list item.
*/

import React from "react";

function Navbar ({links}) {
    return (
        <nav>
            <ul>
            {links.map((link) => (
            <li key={link.id}>
                <a href={link.href}>{link.text}</a>
            </li>            
            ))}
            </ul>
        </nav>
    )
}

export default Navbar;