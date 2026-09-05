import { useState, useEffect } from 'react';
import { getAssignments } from './api/assignments';
import './App.css';

function App() {
    const [assignments, setAssignments] = useState([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        getAssignments()
            .then((response) => setAssignments(response.data))
            .catch((err) => setError(err.message))
            .finally(() => setLoading(false));
    }, []);

    if (loading) return <p>Loading assignments...</p>;
    if (error) return <p>Error: {error}</p>;

    return (
        <div>
            <h1>My Assignments</h1>
            {assignments.length === 0 ? (
                <p>No assignments yet.</p>
            ) : (
                <ul>
                    {assignments.map((a) => (
                        <li key={a.id}>
                            <strong>{a.title}</strong> — {a.course} (due {new Date(a.dueDate).toLocaleDateString()})
                        </li>
                    ))}
                </ul>
            )}
        </div>
    );
}

export default App;