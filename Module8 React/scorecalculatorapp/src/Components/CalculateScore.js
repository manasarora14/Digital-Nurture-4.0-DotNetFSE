// JavaScript source code
import React, { useState } from 'react';
import '../Stylesheets/mystyle.css';

const CalculateScore = () => {
    const [math, setMath] = useState(0);
    const [science, setScience] = useState(0);
    const [english, setEnglish] = useState(0);
    const [total, setTotal] = useState(0);

    const handleCalculate = () => {
        const sum = parseInt(math) + parseInt(science) + parseInt(english);
        setTotal(sum);
    };

    return (
        <div className="score-card">
            <h2>Score Calculator</h2>
            <input type="number" placeholder="Math" onChange={(e) => setMath(e.target.value)} />
            <input type="number" placeholder="Science" onChange={(e) => setScience(e.target.value)} />
            <input type="number" placeholder="English" onChange={(e) => setEnglish(e.target.value)} />
            <button onClick={handleCalculate}>Calculate Total</button>
            <h3>Total Score: {total}</h3>
        </div>
    );
};

export default CalculateScore;

