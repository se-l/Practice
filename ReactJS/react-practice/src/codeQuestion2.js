/*
 Write a Higher-Order Component (HOC) called withAuthentication that wraps a component and 
 provides an isAuthenticated prop indicating whether the user is authenticated or not. 
 Assume there’s an authenticate function that returns a boolean value.
*/

import React from "react";

export default function HOC(WrappedComponent) {
    return function WithAuth(props) {
        return <WrappedComponent {...props} isAuth={isauthenticate()}/>;
    }
}