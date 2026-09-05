import axios from 'axios';

const API_URL = 'https://localhost:7206/api/assignments';

export const getAssignments = () => axios.get(API_URL);
export const createAssignment = (assignment) => axios.post(API_URL, assignment);
export const updateAssignment = (id, assignment) => axios.put(`${API_URL}/${id}`, assignment);
export const deleteAssignment = (id) => axios.delete(`${API_URL}/${id}`);