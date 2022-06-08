import * as React from 'react';
import * as ReactDOM from 'react-dom';
import { registerReactControl } from 'dotvvm-jscomponent-react';

// React component
function ReactButton(props) {
    return (
        <input
            type="button"
            value={props.text}
            onClick={(_) => props.onClick()} />
    );
}

export default (context) => { 
    return {
        $controls: {
            ReactButton: registerReactControl(ReactButton, {
                context,
                onClick() { /* default value for props.onClick */ }
            })
        }
    }
}