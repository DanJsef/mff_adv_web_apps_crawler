import typescript from '@rollup/plugin-typescript'
import resolve from '@rollup/plugin-node-resolve';
import commonjs from '@rollup/plugin-commonjs';
import replace from '@rollup/plugin-replace';
import ts from 'typescript'

const production = false; // !process.env.ROLLUP_WATCH;

export default [{
    input: './wwwroot/Main.tsx',
    output: {
        format: 'esm',
        file: './wwwroot/build/react-app.js',
        sourcemap: true
    },
    plugins: [
        resolve({ browser: true }),
        commonjs({
            include: 'node_modules/**'
        }),
        typescript({ typescript: ts }),
        replace({
            'process.env.NODE_ENV': JSON.stringify('development')
        })
    ]
}]

